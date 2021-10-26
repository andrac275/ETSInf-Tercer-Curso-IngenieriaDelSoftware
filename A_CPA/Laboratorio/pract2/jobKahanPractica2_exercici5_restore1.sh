#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa

#Millors planificadors
echo "Fichero restore 1 imagen Grande"
OMP_NUM_THREADS=2 OMP_SCHEDULE=XXXXXX ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=4 OMP_SCHEDULE=XXXXXX ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=8 OMP_SCHEDULE=XXXXXX ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=16 OMP_SCHEDULE=XXXXXX ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2
echo ""
OMP_NUM_THREADS=32 OMP_SCHEDULE=XXXXXX ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2