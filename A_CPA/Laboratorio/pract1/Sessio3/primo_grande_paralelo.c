#include <stdio.h>
#include <math.h>
#include <limits.h>
#include <omp.h>

typedef unsigned long long Entero_grande;
#define ENTERO_MAS_GRANDE  ULLONG_MAX

int primo(Entero_grande n)
{
  volatile int p;
  int inc, i_ini;
  Entero_grande i, s;

  p = (n % 2 != 0 || n == 2);

  if (p) {
    s = sqrt(n);
    #pragma omp parallel private(inc, i_ini, i)
    { 
      inc=omp_get_num_threads();
      i_ini=omp_get_thread_num();

      for (i = 3 + 2 * i_ini; p && i <= s; i += 2 * inc)
        if (n % i == 0) p = 0;
    } 
  }

  return p;
}

int main()
{
  Entero_grande n;

/*Les seguents dos variables son per a mesurar el temps de execucio*/
   double t1, t2;

/*Comprobar numero de hilos*/   
    #pragma omp parallel
        if(omp_get_thread_num() == 0){              
        printf("Numero de hilos paralelos: %d\n", 
        omp_get_num_threads());
    }

   t1=omp_get_wtime();

  for (n = ENTERO_MAS_GRANDE; !primo(n); n -= 2) {
    /* NADA */
  }

     t2=omp_get_wtime();
   printf("Temps de execucio: %f\n", t2 - t1);

  printf("El mayor primo que cabe en %lu bytes es %llu.\n",
         sizeof(Entero_grande), n);

  return 0;
}
