#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa

#Millors planificadors
echo "EXERCICI 6"
OMP_NUM_THREADS=4 OMP_SCHEDULE=static ./restore3 -i /scratch/cpa/grande.ppm -o "" -b 2
