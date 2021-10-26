#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa

#Probar 'static', 'static,1' i 'dynamic'
echo "Fichero restore 1 imagen Grande"
#echo "STATIC"
#OMP_NUM_THREADS=16 OMP_SCHEDULE=static ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2
#echo "STATIC CHUNK 1"
#OMP_NUM_THREADS=16 OMP_SCHEDULE=static,1 ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2
echo "DYNAMIC"
OMP_NUM_THREADS=16 OMP_SCHEDULE=dynamic ./restore1 -i /scratch/cpa/grande.ppm -o "" -b 2
