#!/bin/sh
#SBATCH --nodes=2
#SBATCH --ntasks=8
#SBATCH --time=5:00
#SBATCH --partition=cpa
#scontrol show hostnames $SLURM_JOB_NODELIST
echo "Job per a 8 processos"
mpiexec ./newton_exercici3 -c5