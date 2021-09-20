//Diapos 39 de 97. Pruebas con ARRAYS
let users =["Andreu", "Marc","Alvaro","Carlos"] 

for (let c = 0; c< users.length;c++)
    console.log(users[c])

console.log()
let locations=[]
locations[1]="Valencia"
console.log(locations[0])  
console.log(locations[1])  
console.log(locations[2])  
console.log()

//No se copia el array, se copia una referencia. Si dius que newUsers[2] es Laura, machacara a "Alvaro" en "users"
let newUsers = users
newUsers[2] = "Laura"
console.log(users[2]) 

console.log()
users =["Andreu", "Marc","Alvaro","Carlos"] 
newUsers = users.slice()
newUsers[2] = "Laura"
console.log("Con slice no se machaca el array inicial: " + users[2])
console.log("Copia el array perfectamente y tras machacar aparece en el nuevo array: " + newUsers[2] )

console.log()

//Meter y borrar elementos a un array. Añadir y borrar al principio i al final
users =["Andreu", "Marc","Alvaro","Carlos"] 
console.log("Añadir Juan al principio")
users.unshift("Juan")
for (let c = 0; c< users.length;c++)
    console.log(users[c])

console.log()
console.log("Borrar Juan del principio")
users.shift()
for (let c = 0; c< users.length;c++)
    console.log(users[c])

console.log()
users =["Andreu", "Marc","Alvaro","Carlos"] 
console.log("Añadir Juan al final")
users.push("Juan")
for (let c = 0; c< users.length;c++)
    console.log(users[c])

console.log()
console.log("Borrar Juan del final")
users.pop()
for (let c = 0; c< users.length;c++)
    console.log(users[c])

console.log()

console.log()