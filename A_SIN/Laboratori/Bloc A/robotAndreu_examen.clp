;ExerciciRobot: Estat, Nivell i Nodes_Generats      Comentar: Ctrl+K+C    Descomentar: Ctrl+K+U
;Variabes globals
(defglobal ?*Profunditat* = 1)
(defglobal ?*N* = 0)

;BASE DE FETS
(deffacts robotLlaunes
    ;Map = mapa (Map ?Amplaria ?Altura)
    (Map 8 5)   

    ;Con = Contenidor (Con ?eix_X ?eix_Y)
    (Con 1 3 1) (Con 1 5 1) (Con 2 1 1) (Con 4 3 1) (Con 4 5 1) (Con 6 1 1) (Con 7 5 1) (Con 8 1 1) (Con 8 3 1)     

    ;Robot i fets dinamics
    ; R=Robot LL=Llaunes
    ; (R ?c ?f  LL [L ?cl ?fl]ˆm n ?n)
    ; c=eix_X f=eix_Y cl/fl=eix_X/eix_Y n=nodes_generats
    (R 2 3 LL L 3 3 1 L 3 1 1 L 6 4 1 n 0)
    
)


;DEFINICIO DE REGLES
;Moure a casilla buida
    ;Moure BAIX a BUIT
    (defrule baixarBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con ?x =(- ?y 1) ?z))
    (test (> ?y 1))
    (test (not (member$ (create$ L ?x (- ?y 1)) $?llaunes)))
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (- ?y 1) $?llaunes n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)
	
	;Moure PUJAR a BUIT
    (defrule pujarBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con ?x =(+ ?y 1) ?z))
    (test (< ?y ?My))
    (test (not (member$ (create$ L ?x (+ ?y 1)) $?llaunes)))
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (+ ?y 1) $?llaunes n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)
	
	;Moure DRETA a BUIT
    (defrule dretaBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con =(+ ?x 1) ?y ?z))
    (test (< ?x ?Mx))
    (test (not (member$ (create$ L (+ ?x 1) ?y) $?llaunes)))
    (test (< ?n ?*Profunditat*))
        => (assert (R (+ ?x 1) ?y $?llaunes n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

	;Moure ESQUERRA a BUIT
    (defrule esquerraBuit (Map ?Mx ?My) (R ?x ?y $?llaunes n ?n) (not (Con =(- ?x 1) ?y ?z))
    (test (> ?x 1))
    (test (not (member$ (create$ L (- ?x 1) ?y) $?llaunes)))
    (test (< ?n ?*Profunditat*))
        => (assert (R (- ?x 1) ?y $?llaunes n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

;Moure espentant llauna
    ;Moure BAIX a ESPENTANT
    (defrule baixarEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?x ?ly ?lz $?algoDespres n ?n) (not (Con ?x =(- ?y 1) ?z)) (not (Con ?x =(- ?y 2) ?z))
    (test (> ?ly 1))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?ly (- ?y 1)))
    (test (not (member$ (create$ L ?x (- ?ly 1) ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L ?x (- ?ly 1) ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (- ?y 1) $?algoAntes L ?x (- ?ly 1) ?lz $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

    ;Moure DALT a ESPENTANT
    (defrule pujarEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?x ?ly ?lz $?algoDespres n ?n) (not (Con ?x =(+ ?y 1) ?z)) (not (Con ?x =(+ ?y 2) ?z))
    (test (< ?ly ?My))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?ly (+ ?y 1)))
    (test (not (member$ (create$ L ?x (+ ?ly 1) ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L ?x (+ ?ly 1) ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (+ ?y 1) $?algoAntes L ?x (+ ?ly 1) ?lz $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

    ;Moure ESQUERRA a ESPENTANT
    (defrule esquerraEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?lx ?y ?lz $?algoDespres n ?n) (not (Con =(- ?x 1) ?y ?z)) (not (Con =(- ?x 2) ?y ?z))
    (test (> ?lx 1))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?lx (- ?x 1)))

    (test (not (member$ (create$ L (- ?lx 1) ?y ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L (- ?lx 1) ?y ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R (- ?x 1) ?y $?algoAntes L (- ?lx 1) ?y ?lz $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

    ;Moure DRETA a ESPENTANT
    (defrule dretaEspentant (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?lx ?y ?lz $?algoDespres n ?n) (not (Con =(+ ?x 1) ?y ?z)) (not (Con =(+ ?x 2) ?y ?z))
    (test (< ?lx ?Mx))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?lx (+ ?x 1)))

    (test (not (member$ (create$ L (+ ?lx 1) ?y ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L (+ ?lx 1) ?y ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R (+ ?x 1) ?y $?algoAntes L (+ ?lx 1) ?y ?lz $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

;Moure espentant llauna a Contenidor
    ;Moure BAIX a ESPENTANT a CONTENIDOR
    (defrule baixarEspentantContenidor 
        (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?x ?ly ?lz $?algoDespres n ?n) 
        (not (Con ?x =(- ?y 1) ?z))    ;No contenidor en adyacent
        (Con ?x =(- ?y 2) ?z)          ;Si contenidor 2 en direccio a espentar
    (test (= ?lz ?z))
    (test (> ?ly 1))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?ly (- ?y 1)))
    (test (not (member$ (create$ L ?x (- ?ly 1) ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L ?x (- ?ly 1) ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (- ?y 1) $?algoAntes $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

    ;Moure DALT a ESPENTANT a CONTENIDOR
    (defrule pujarEspentantContenidor 
        (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?x ?ly ?lz $?algoDespres n ?n) 
        (not (Con ?x =(+ ?y 1) ?z))    ;No contenidor en adyacent
        (Con ?x =(+ ?y 2) ?z)          ;Si contenidor 2 en direccio a espentar
    (test (= ?lz ?z))
    (test (< ?ly ?My))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?ly (+ ?y 1)))
    (test (not (member$ (create$ L ?x (+ ?ly 1) ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L ?x (+ ?ly 1) ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R ?x (+ ?y 1) $?algoAntes $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

    ;Moure ESQUERRA a ESPENTANT a CONTENIDOR
    (defrule esquerraEspentantContenidor 
        (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?lx ?y ?lz $?algoDespres n ?n) 
        (not (Con =(- ?x 1) ?y ?z))    ;No contenidor en adyacent
        (Con =(- ?x 2) ?y ?z)          ;Si contenidor 2 en direccio a espentar
    (test (= ?lz ?z))
    (test (> ?lx 1))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?lx (- ?x 1)))

    (test (not (member$ (create$ L (- ?lx 1) ?y ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L (- ?lx 1) ?y ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R (- ?x 1) ?y $?algoAntes $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

    ;Moure DRETA a ESPENTANT a CONTENIDOR
    (defrule dretaEspentantContenidor 
        (Map ?Mx ?My) (R ?x ?y $?algoAntes L ?lx ?y ?lz $?algoDespres n ?n) 
        (not (Con =(+ ?x 1) ?y ?z))    ;No contenidor en adyacent
        (Con =(+ ?x 2) ?y ?z)          ;Si contenidor 2 en direccio a espentar
    (test (= ?lz ?z))
    (test (< ?lx ?Mx))    ;Comprovar que no tirare la llauna fora del quadre
    (test (= ?lx (+ ?x 1)))

    (test (not (member$ (create$ L (+ ?lx 1) ?y ?lz) $?algoAntes)))     ;Comprovar en la cadena de abans que no hi ha una llauna on vull espentar
    (test (not (member$ (create$ L (+ ?lx 1) ?y ?lz) $?algoDespres)))   ;Comprovar en la cadena de despres que no hi ha una llauna on vull espentar
    (test (< ?n ?*Profunditat*))
        => (assert (R (+ ?x 1) ?y $?algoAntes $?algoDespres n (+ ?n 1)))
        (bind ?*N* (+ ?*N* 1))
	)

;Objetiu
    (defrule objectiu 
    (declare (salience 1))
    (R ?x ?y LL n ?n) 
        => (printout t "Llaunes netes! n=" ?n " N=" ?*N* crlf) (halt)) 


;Funcio per introduir la configuracio del programa
(deffunction setConfiguracio ()
    (reset)
    (printout t "Profunditad Maxima??? " )
    (bind ?*Profunditat* (read))
    (printout t "Tipo de búsqueda: (1)Amplària/Breadth --- (2)Profundidad/Depth")
    (bind ?a (read))
        (if (= ?a 1)
            then (set-strategy breadth)
            else (set-strategy depth)
        )
)

(watch facts)
(watch activations)
(setConfiguracio)    ;Cridar funcio introduir configuracio del programa
;(set-strategy breadth)     ;Breadth: Amplaria
;(set-strategy depth)     ;Depth: Profunditat. No possar estrategia implica depth
;(reset)
(run)
(exit)