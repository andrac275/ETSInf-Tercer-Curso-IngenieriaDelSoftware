#include <stdio.h>
#include <math.h>
#include <limits.h>
#include <omp.h>

typedef unsigned long long Entero_grande;
#define ENTERO_MAS_GRANDE  ULLONG_MAX

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
  Entero_grande n;
  /*Les seguents dos variables son per a mesurar el temps de execucio*/
   double t1, t2;

printf("Sense paralelitzacio: \n ");

/*ANDREU; Punt inicial del cronometro del filtro*/
   t1=omp_get_wtime();

  for (n = ENTERO_MAS_GRANDE; !primo(n); n -= 2) {
    /* NADA */
  }

  /*ANDREU: Punt final del cronometro*/
   t2=omp_get_wtime();
   printf("Temps de execucio: %f\n", t2 - t1);

  printf("El mayor primo que cabe en %lu bytes es %llu.\n",
         sizeof(Entero_grande), n);

  return 0;
}
