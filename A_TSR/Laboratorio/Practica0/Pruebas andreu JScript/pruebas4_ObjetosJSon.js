//50 de 97

let person ={ name:"Andreu",
                age:30,
                address: {
                    city:"Valencia",
                    street:"BlascoIbañez",
                    number:50
                }
            }
console.log(JSON.stringify(person))

//51 DE 97
console.log();
for(let i in person){
    console.log("Propiedad " + i + ": " + person[i]);
}
for (let i in person.address){
    console.log("Propiedad " + i + ": " + person.address[i]);
}
