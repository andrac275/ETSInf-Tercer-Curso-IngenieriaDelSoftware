#!/bin/sh
#SBATCH --nodes=2
#SBATCH --ntasks=4
#SBATCH --time=5:00
#SBATCH --partition=cpa
#scontrol show hostnames $SLURM_JOB_NODELIST
echo "Job per a 4 processos"
echo "Ejecutando sistbf"
mpiexec ./sistbf_ejer4 1500

echo "Ejecutando sistcf"
mpiexec ./sistcf_ejer4 1500