#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa

OMP_NUM_THREADS=2 ./bucle4
OMP_NUM_THREADS=8 ./bucle4
OMP_NUM_THREADS=32 ./bucle4
