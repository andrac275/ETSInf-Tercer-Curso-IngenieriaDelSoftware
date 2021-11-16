#include <stdio.h>
#include <mpi.h>

int main(int argc, char *argv[]){
    int numProcs,myID;
    MPI_Init(&argc,&argv);
    MPI_Comm_size(MPI_COMM_WORLD, &numProcs);
    MPI_Comm_rank(MPI_COMM_WORLD, &myID);
    printf("Hello world\n");
    printf("El identificador del proces es: %d El numero de procesos es: %d \n",numProcs,myID);
    MPI_Finalize();
    return 0;
} 
