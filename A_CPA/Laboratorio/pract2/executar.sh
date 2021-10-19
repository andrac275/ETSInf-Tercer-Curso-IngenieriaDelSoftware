#!/bin/bash

./restore0 -i peque.ppm -o pequeOut.ppm -b 8

OMP_NUM_THREADS=4 ./restore1 -i peque.ppm -o pequeOut_1.ppm -b 8
OMP_NUM_THREADS=4 ./restore1 -i grande.ppm -o grandeOut_1.ppm -b 2

OMP_NUM_THREADS=4 ./restore2 -i peque.ppm -o pequeOut_2.ppm -b 8
OMP_NUM_THREADS=4 ./restore2 -i grande.ppm -o grandeOut_2.ppm -b 2
