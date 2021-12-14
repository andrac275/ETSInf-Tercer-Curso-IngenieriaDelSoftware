#!/bin/bash
mpicc -o sistcf ~/W/CPA/pract3/sessio4/sistcf.c
mpiexec -n 3 sistcf 5
