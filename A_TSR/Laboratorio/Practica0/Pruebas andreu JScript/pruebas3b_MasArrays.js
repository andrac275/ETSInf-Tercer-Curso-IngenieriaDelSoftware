//44 de 97. Mas cosas de arrays.

//PseudoArrays que se transforman a Array con Array.from()
function list(){
    return Array.from(arguments)
}

let list1 = list(1,2,3)
console.log(list1)
console.log()

//Tipo estructurado object
let person ={ name:"Andreu",
                age:30,
                address: {
                    city:"Valencia",
                    street:"BlascoIbañez",
                    number:50
                }
            } 
console.log(person)
console.log()

//o tambien asi de manera dinamica:
person={}
person.name="Andreu"
person.age=30
person.address={}
person.address.city="Valencia"
person.address.street="BlascoIbañez"
person.address.number=50
console.log(person)
console.log()

//Hay una tercera manera que esta en la diapos 47

//Prueba para si no esta definido algo
console.log("Prueba para si no esta definido algo")
person={}
person.name="Andreu"
person.age=30
console.log(person.district) 
console.log()

function printDistrict(who){
    console.log("Nom: "+ who.name)
    console.log("District: "+who.district)
} 
person ={ name:"Andreu",
                age:30,
                address: {
                    city:"Valencia",
                    street:"BlascoIbañez",
                    number:50
                }
            }
printDistrict(person)