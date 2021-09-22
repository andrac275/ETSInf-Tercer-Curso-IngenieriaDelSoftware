/*El require es per a importar una biblioteca i se importa en una variable constant. La biblioteca se diu fs */
const fs = require ('fs')
/*Tenim un metode readFile per llegir el contingut dun fitxer, pero requereix una funcio anomima que processe dos arguments, si hi ha errors i el contingut */
fs.readFile('importar.js',(errors, datos)=>{
    console.log("" + datos)
})