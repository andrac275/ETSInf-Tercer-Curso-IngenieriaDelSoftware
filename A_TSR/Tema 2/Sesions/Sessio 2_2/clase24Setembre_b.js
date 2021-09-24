function contador(){
	var x= 0
	return ()=>x++;
}
const a = contador()
const b = contador()

console.log(a(),a(),b(),a(),b())