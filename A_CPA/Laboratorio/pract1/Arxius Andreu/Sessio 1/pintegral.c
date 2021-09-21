#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <omp.h>

/* Funcion f(x) de la cual se quiere calcular la integral */
double f(double x)
{
//   return pow(10*x-14.0/3.0,3)-150*x+120;
   return M_PI/2.0*sin(x*M_PI);
}

/* Calculo de la integral de la funcion f. Variante 1 */
double calcula_integral1(double a, double b, int n)
{
   double h, s=0, result;
   int i;

   h=(b-a)/n;
   /*Aci ANDREU: La seguent linea es una directiva que activa el paralelisme*/
    #pragma omp parallel
    /*El if es per controlar que el print nomes el fa el fil zero.*/
    if(omp_get_thread_num() == 0){
        /*la segünent linea la imprimiria tots els fils pero el IF de la linea anterior fa que nomes ho imprimisca el fil 0, aleshores nomes se imprimira una vegada*/        
        printf("Numero de hilos paralelos: %d\n", 
        omp_get_num_threads());
    }
    
    /*reduction (+:s) fa que la variable s que es una suma (de ahi +:s) funcione correctament*/
   #pragma omp parallel for reduction(+:s)
   for (i=0; i<n; i++) {     
      s+=f(a+h*(i+0.5));
   }

   result = h*s;
   return result;
}

/* Calculo de la integral de la funcion f. Variante 2 */
double calcula_integral2(double a, double b, int n)
{
   double x, h, s=0, result;
   int i;

   h=(b-a)/n;
   
   /*El reduction +:s es per a acumular la suma mentre que el private x es perque la variable x la utilitza cada un dels fils, no fa falta "possarho" en comu entre els fils.*/
#pragma omp parallel for reduction(+:s) private(x)
   for (i=0; i<n; i++) {
      x=a;
      x+=h*(i+0.5);

      s+=f(x);
   }

   result = h*s;
   return result;
}

int main(int argc, char *argv[])
{
   double a, b, result;
   int n, variante;
   
   if (argc<2) {
      fprintf(stderr, "Numero de argumentos incorrecto\n");
      return 1;
   }
   if (argc>2) n=atoi(argv[2]);
   else n=100000;
   a=0;
   b=1;

   variante=atoi(argv[1]);
   
    /*Les seguents dos variables son per a mesurar el temps de execucio*/
   double t1, t2;
   
   /*Punt inicial del cronometro*/
   t1=omp_get_wtime();

   switch (variante) {
      case 1:
         result = calcula_integral1(a,b,n);         
         break;
      case 2:
         result = calcula_integral2(a,b,n);
         break;
      default:
         fprintf(stderr, "Numero de variante incorrecto\n");
         return 1;
   }
   
      /*Punt final del cronometro*/
   t2=omp_get_wtime();
   printf("Temps de execucio: %f\n", t2 - t1);
   
   printf("Valor de la integral = %.12f\n", result);

   return 0;
}
