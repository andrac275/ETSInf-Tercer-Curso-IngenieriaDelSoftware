#!/bin/bash
gcc -fopenmp -Wall -o primo_grande_paralelo primo_grande_paralelo.c -lm
gcc -fopenmp -Wall -o primo_numeros_paralelo primo_numeros_paralelo.c -lm