#!/bin/bash
#SBATCH --nodes=1
#SBATCH --time=5:00
#SBATCH --partition=cpa

#echo "Fichero restore 1 imagen pequeña"
OMP_NUM_THREADS=16 ./restore1 -i peque.ppm -o pequeOut_1.ppm -b 8

#echo "Fichero restore 2 imagen pequeña"
OMP_NUM_THREADS=16 ./restore2 -i peque.ppm -o pequeOut_2.ppm -b 8

#echo "Fichero restore 1 imagen Grande"
OMP_NUM_THREADS=16 ./restore1 -i grande.ppm -o grandeOut_1.ppm -b 2

#echo "Fichero restore 2 imagen Grande"
OMP_NUM_THREADS=16 ./restore2 -i grande.ppm -o grandeOut_2.ppm -b 2