        .data
a:      .dword  9,8,0,1,0,5,3,1,2,0
tam:    .dword 10       ; Tamaño del vector
cont:   .dword 0        ; Número de componentes == 0

        .text
start:	dadd r1,$gp,a   ; Puntero
        ld r4,tam($gp)  ; Tamaño lista
        dadd r10,r0,r0  ; Contador de ceros
 
loop:
	ld r12,0(r1)    ;carregar dada del vector
        dadd r1,r1,#8   ;moure punter a seguent dada del vector           
        daddi r4, r4, -1 ;restar 1 dada per llegir
        beqz r12, mas1  ;si es un 0 el element del vector...
        bnez r4, loop   ;si encara queden dades per llegir, iterar loop
acabar:
        nop
        nop
        trap #0

mas1:   daddi r10,r10,1 ;sumar 1 al contador de zeros.
        bnez r4, loop   ;si encara queden dades per llegir, iterar loop
        j acabar



