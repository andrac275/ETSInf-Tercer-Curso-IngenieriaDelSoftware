#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa

#Millors planificadors
echo "Fichero restore 2 imagen Grande planificador static"
OMP_NUM_THREADS=2 OMP_SCHEDULE=static ./restore2 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=4 OMP_SCHEDULE=static ./restore2 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=8 OMP_SCHEDULE=static ./restore2 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=16 OMP_SCHEDULE=static ./restore2 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=32 OMP_SCHEDULE=static ./restore2 -i /scratch/cpa/grande.ppm -o "" -b 2