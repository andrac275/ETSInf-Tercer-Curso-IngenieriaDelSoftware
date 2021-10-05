#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa

OMP_NUM_THREADS=4 ./primo_numeros_paralelo
OMP_NUM_THREADS=8 ./primo_numeros_paralelo
OMP_NUM_THREADS=16 ./primo_numeros_paralelo
