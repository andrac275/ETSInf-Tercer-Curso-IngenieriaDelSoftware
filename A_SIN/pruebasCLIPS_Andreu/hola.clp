; El punt i coma al inici de linea serveix per a comentar.

(deffacts bf(pendent Manel Nora Laia))

(defrule saluda
    ?f <- (pendent ?x $?y)
    =>
    (printout t "Hola " ?x crlf)
    (printout t "Encara em queda saludar " $?y crlf)
    ;(retract ?f)
    (assert (pendent $?y))
    (assert (pendent ?x))
    )
    

(defrule acaba (pendent) => (halt))

(watch facts)
(watch activations)
(set-strategy breadth)
(reset)
(run)
(exit)
