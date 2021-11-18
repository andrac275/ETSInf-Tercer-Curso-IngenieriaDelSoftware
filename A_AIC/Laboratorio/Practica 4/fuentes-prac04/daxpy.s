        ; z = a*x + y
        ; Tamaño de los vectores: 64 palabras
        ; Vector x
	.data
x:      .double 0,1,2,3,4,5,6,7,8,9
        .double 10,11,12,13,14,15,16,17,18,19
        .double 20,21,22,23,24,25,26,27,28,29
        .double 30,31,32,33,34,35,36,37,38,39
        .double 40,41,42,43,44,45,46,47,48,49
        .double 50,51,52,53,54,55,56,57,58,59

	; Vector y
y:      .double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100
	.double 100,100,100,100,100,100,100,100,100,100

        ; Vector z
	; 60 elementos son 480 bytes
z:      .space 480

        ; Escalar a
a:      .double 1

        ; El código
	.text

start:
        dadd r1,r0,x     ; ANDREU: r1 per al vector x
        dadd r2,r0,y     ; r2 contiene la direccion de y
        dadd r3,r0,z     ; r3 contiene la direccion de z	
        dadd r4,r1,#480	 ; 60 elementos son 480 bytes
        l.d f0,a(r0)     ; f0 contiene a

loop:   
        ;ANDREU: Cal fer Z=a*X+Y
	l.d f1,0(r1)   ;Cargar el valor del vector X
        l.d f2,0(r2)   ;Cargar el valor del vector Y
	mul.d f3,f1,f0        ;Multiplicar a*X
        add.d f4,f2,f3 ;Sumarli a lo anterior la Y-> a*X+Y
        s.d f4,0(r3)   ;Guardar en memoria en Z
        dadd r1,r1,#8  ;Avançar punter x
        dadd r2,r2,#8  ;Avançar punter y
        dadd r3,r3,#8  ;Avançar punter z
        dsub r5,r4,r1  ;Llevar una iteracio
        bnez r5,loop

        trap 0         ; Fin de programa
        


