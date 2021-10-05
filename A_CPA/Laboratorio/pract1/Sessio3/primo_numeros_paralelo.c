#include <stdio.h>
#include <math.h>
#include <omp.h>

typedef unsigned long long Entero_grande;
#define N 60000000ULL

int primo(Entero_grande n)
{
  int p;
  Entero_grande i, s;

  p = (n % 2 != 0 || n == 2);

  if (p) {
    s = sqrt(n);

    for (i = 3; p && i <= s; i += 2)
      if (n % i == 0) p = 0;
  }

  return p;
}

int main()
{
  Entero_grande i, n;

/*Les seguents dos variables son per a mesurar el temps de execucio*/
   double t1, t2;

/*Comprobar numero de hilos*/   
    #pragma omp parallel
        if(omp_get_thread_num() == 0){              
        printf("Numero de hilos paralelos: %d\n", 
        omp_get_num_threads());
    }

  t1=omp_get_wtime();

  n = 2; /* Por el 1 y el 2 */
  #pragma omp parallel for reduction(+:n)
  for (i = 3; i <= N; i += 2){
    if (primo(i)) n++;
  }

  t2=omp_get_wtime();
  printf("Temps de execucio: %f\n", t2 - t1);

  printf("Entre el 1 y el %llu hay %llu numeros primos.\n",
         N, n);

  return 0;
}
