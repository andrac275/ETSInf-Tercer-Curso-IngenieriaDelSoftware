#!/bin/sh
#SBATCH --nodes=2
#SBATCH --ntasks=3
#SBATCH --time=5:00
#SBATCH --partition=cpa
#scontrol show hostnames $SLURM_JOB_NODELIST
echo "Job per a 3 processos i 1000 sistemes"
echo "Ejecutando sistbf"
mpiexec ./sistbf_ejer4 1000
echo "Ejecutando sistcf"
mpiexec ./sistcf_ejer4 1000
echo "-------------------------------"
echo "Job per a 3 processos i 1500 sistemes"
echo "Ejecutando sistbf"
mpiexec ./sistbf_ejer4 1500
echo "Ejecutando sistcf"
mpiexec ./sistcf_ejer4 1500