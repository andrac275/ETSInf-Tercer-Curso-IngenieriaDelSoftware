;ExerciciRobot: Estat, Nivell i Nodes_Generats      Comentar: Ctrl+K+C    Descomentar: Ctrl+K+U
(defglobal ?*Profunditat* = 2)
(defglobal ?*Nod_Gen* = 0)

;BASE DE FETS
(deffacts robotLlaunes
    ;Map = mapa (Map ?Amplaria ?Altura)
    (Map 5 5)   

    ;Con = Contenidor (Con ?eix_X ?eix_Y)
    (Con 1 1) (Con 3 5) (Con 1 3)

    ;Robot i fets dinamics
    ; R=Robot LL=Llaunes
    ; (R ?c ?f  LL [L ?cl ?fl]ˆm n ?n)
    ; c=eix_X f=eix_Y cl/fl=eix_X/eix_Y n=nodes_generats
    (R 3 3 LL L 3 2  L 3 4 L 2 3 n 0)
    
)

;DEFINICIO DE REGLES
;Moure a casilla buida
    ; ;Moure BAIX a BUIT
    ; (defrule baixarBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con ?x =(- ?y 1)))
    ; (test (> ?y 1))
    ; (test (not (member$ (create$ L ?x (- ?y 1)) $?llaunes)))
    ; (test (< ?n ?*Profunditat*))
    ;     => (assert (R ?x (- ?y 1) $?llaunes n (+ ?n 1)))
    ;     (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	; )
	
	; ;Moure PUJAR a BUIT
    ; (defrule pujarBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con ?x =(+ ?y 1)))
    ; (test (< ?y ?My))
    ; (test (not (member$ (create$ L ?x (+ ?y 1)) $?llaunes)))
    ; (test (< ?n ?*Profunditat*))
    ;     => (assert (R ?x (+ ?y 1) $?llaunes n (+ ?n 1)))
    ;     (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	; )
	
	; ;Moure DRETA a BUIT
    ; (defrule dretaBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con =(+ ?x 1) ?y))
    ; (test (< ?x ?Mx))
    ; (test (not (member$ (create$ L (+ ?x 1) ?y) $?llaunes)))
    ; (test (< ?n ?*Profunditat*))
    ;     => (assert (R (+ ?x 1) ?y $?llaunes n (+ ?n 1)))
    ;     (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	; )

	; ;Moure ESQUERRA a BUIT
    ; (defrule esquerraBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con =(- ?x 1) ?y))
    ; (test (> ?x 1))
    ; (test (not (member$ (create$ L (- ?x 1) ?y) $?llaunes)))
    ; (test (< ?n ?*Profunditat*))
    ;     => (assert (R (- ?x 1) ?y $?llaunes n (+ ?n 1)))
    ;     (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	; )

;Moure espentant llauna
    ;Moure BAIX a ESPENTANT
    (defrule baixarEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?x ?ly $?algoDespres n ?n) (not (Con ?x =(- ?y 1))) (not (Con ?x =(- ?y 2)))
    (test (> ?ly 1))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?ly (- ?y 1)))
    (test (not (member$ (create$ L ?x (- ?ly 1)) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L ?x (- ?ly 1)) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (- ?y 1) $?algoAntes L ?x (- ?ly 1) $?algoDespres  n (+ ?n 1)))
        (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	)

    ;Moure DALT a ESPENTANT
    (defrule pujarEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?x ?ly $?algoDespres n ?n) (not (Con ?x =(+ ?y 1))) (not (Con ?x =(+ ?y 2)))
    (test (< ?ly ?My))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?ly (+ ?y 1)))
    (test (not (member$ (create$ L ?x (+ ?ly 1)) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L ?x (+ ?ly 1)) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (+ ?y 1) $?algoAntes L ?x (+ ?ly 1) $?algoDespres  n (+ ?n 1)))
        (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	)

    ;Moure ESQUERRA a ESPENTANT
    (defrule esquerraEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?lx ?y $?algoDespres n ?n) (not (Con =(- ?x 1) ?y)) (not (Con =(- ?x 2) ?y))
    (test (> ?lx 1))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?lx (- ?x 1)))

    (test (not (member$ (create$ L (- ?lx 1) ?y) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L (- ?lx 1) ?y) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R (- ?x 1) ?y $?algoAntes L (- ?lx 1) ?y $?algoDespres  n (+ ?n 1)))
        (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	)

    ;Moure DRETA a ESPENTANT
    ;ESTIC ACI ANDREU
    (defrule dretaEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?lx ?y $?algoDespres n ?n) (not (Con =(- ?x 1) ?y)) (not (Con =(- ?x 2) ?y))
    (test (> ?lx 1))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?lx (- ?x 1)))

    (test (not (member$ (create$ L (- ?lx 1) ?y) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L (- ?lx 1) ?y) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R (- ?x 1) ?y $?algoAntes L (- ?lx 1) ?y $?algoDespres  n (+ ?n 1)))
        (bind ?*Nod_Gen* (+ ?*Nod_Gen* 1))
	)

;Moure espentant llauna a Contenidor


;Objetiu
    (defrule objectiu (R ?x ?y LL n ?n) => (printout t "Llaunes netes!" crlf)) 

(watch facts)
(watch activations)
(set-strategy breadth) ; cal provar depth i breadth
(reset)
(run)
(exit)