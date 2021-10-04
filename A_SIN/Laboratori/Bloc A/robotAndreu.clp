;BASE DE FETS
(deffacts bf
    ;Map = mapa (Map ?Amplaria ?Altura)
    (Map 8 5)   

    ;Con = Contenidor (Con ?columna ?fila)
    (Con 1 3) (Con 1 5) (Con 2 1) (Con 4 3) (Con 4 5) 
    (Con 6 1) (Con 7 5) (Con 8 1) (Con 8 3)     

    ;Robot i fets dinamics
    (R 3 2 LL L 3 3 L 3 1 L 6 4)
        ; R=Robot LL=Llaunes
        ; (R ?c ?f  LL [L ?cl ?fl]ˆm)
        ; c=columna f=fila cl/fl=col/fila
)

;DEFINICIO DE REGLES
;Moure a casilla buida
    ;Moure BAIX a BUIT
    (defrule baixarBuit (Map ?Mx ?My) (R ?x ?y $?llaunes) (not (Con ?x =(- ?y 1)))
    (test (> ?y 1))
    (test (not (member$ (create$ L ?x (- ?y 1)) $?llaunes)))
    => (assert (R ?x (- ?y 1) $?llaunes))
	;=>(printout t "S'ha mogut" crlf)
    )
	
	;Moure PUJAR a BUIT
    (defrule pujarBuit (Map ?Mx ?My) (R ?x ?y $?llaunes) (not (Con ?x =(+ ?y 1)))
    (test (< ?y ?My))
    (test (not (member$ (create$ L ?x (+ ?y 1)) $?llaunes)))
    => (assert (R ?x (+ ?y 1) $?llaunes))
	;=>(printout t "S'ha mogut" crlf)
    )
	
	;Moure DRETA a BUIT
    (defrule dretaBuit (Map ?Mx ?My) (R ?x ?y $?llaunes) (not (Con =(+ ?x 1) ?y))
    (test (< ?x ?Mx))
    (test (not (member$ (create$ L (+ ?x 1) ?y) $?llaunes)))
    => (assert (R (+ ?x 1) ?y $?llaunes))
	;=>(printout t "S'ha mogut" crlf)
    )

	;Moure ESQUERRA a BUIT
    (defrule esquerraBuit (Map ?Mx ?My) (R ?x ?y $?llaunes) (not (Con =(- ?x 1) ?y))
    (test (> ?x 1))
    (test (not (member$ (create$ L (- ?x 1) ?y) $?llaunes)))
    => (assert (R (- ?x 1) ?y $?llaunes))
	;=>(printout t "S'ha mogut" crlf)
    )




;Moure espentant llauna


;Moure espentant llauna a Contenidor


;Objetiu
    (defrule objectiu (R ?c ?f LL) => (printout t "Llaunes netes!" crlf)) 

(watch facts)
(watch activations)
(set-strategy breadth) ; cal provar depth i breadth
(reset)
(run)
(exit)