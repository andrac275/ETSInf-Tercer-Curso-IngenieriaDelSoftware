/* Ping-pong program */

#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>

#define NMAX 1000000
#define NREPS 100

char buf[NMAX];

int main(int argc,char *argv[])
{
  int n, myid, numprocs;
  double temps_Ini,temps_Fi,temps;

  MPI_Init(&argc,&argv);
  MPI_Comm_size(MPI_COMM_WORLD,&numprocs);
  MPI_Comm_rank(MPI_COMM_WORLD,&myid);

  /* The program takes 1 argument: message size (n), with a default size of 100
     bytes and a maximum size of NMAX bytes*/
  if (argc==2) n = atoi(argv[1]);
  else n = 100;
  if (n<0 || n>NMAX) n=NMAX;

  /* COMPLETE: ANDREU. Get current time, using MPI_Wtime() */
   temps_Ini =MPI_Wtime();

  /* COMPLETE: ANDREU. loop of NREPS iterations.
     In each iteration, P0 sends a message of n bytes to P1, and P1 sends the same
     message back to P0. The data sent is taken from array buf and received into
     the same array. */
     for(int i=0; i<NREPS;i++){
        if(myid==0){
           MPI_Send(&n,1,MPI_BYTE,1,275,MPI_COMM_WORLD);
           MPI_Recv(&n,1,MPI_BYTE,1,280,MPI_COMM_WORLD,MPI_STATUS_IGNORE);
        }else if(myid==1){
           MPI_Recv(&n,1,MPI_BYTE,0,275,MPI_COMM_WORLD,MPI_STATUS_IGNORE);
           MPI_Send(&n,1,MPI_BYTE,0,280,MPI_COMM_WORLD);
        }
     }

  /* COMPLETE: ANDREU Get current time, using MPI_Wtime() */
   temps_Fi = MPI_Wtime();

  /* COMPLETE: Only in process 0.
     Compute the time of transmission of a single message (in milliseconds) and print it.
     Take into account there have been NREPS repetitions, and each repetition involves 2
     messages. */
     if(myid==0){
         temps=temps_Fi-temps_Ini;
         printf("El programa ha tardat %f segons.\n",temps);
         temps /= n; //Temps entre nombre de iteracions
         temps /= 2; //Temps entre dos missatges. ping i pong
         temps *=1000;   //Passar segons a milisegons
         printf("Un unic missatge pren %f milisegons \n",temps);
     }

  MPI_Finalize();
  return 0;
}

