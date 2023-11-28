// const fakeapi="https://fakestoreapi.com/products?sort=desc";
const getbutton=document.querySelector("#getpost");
const createbutton=doucment.querySelector("#createpost");
// const updatebutton=document.querySelector("#updatepost");
// const deletebutton=document.querySelector("#deletepost");
//getposts function starts
function displayproducts(hh){
fetch("https://fakestoreapi.com/products?sort=desc")
.then(response=>{
	return response.json();
})
.then(products=>{
	console.log(products)
	let placeholder = document.querySelector("#data-output");
	let out = "";
	for(let product of products){
		out += `
			<tr>
				<td> <img src='${product.image}'> </td>
				<td>${product.title}</td>
				<td>${product.price}</td>
				<td>${product.description}</td>
				<td>${product.category}</td>
				<td>${product.rating.rate}</td>
				<td>${product.rating.count}</td>
			</tr>
		`;
		placeholder.innerHTML = out;
	}
})
};
function createproduct(){
	fetch("https://fakestoreapi.com/products/cars",{
		method:"POST",
		headers:{"content-type":"application/json; charset/UTF-8"}
	})
	.then(response=>{
		return response.json();
	})
	.then(postproduct=>{
		let placeholder = document.querySelector("#data-output");
		let out = "";
		
			out += `
				<tr>
					<td> <img src='${product.image}'> </td>
					<td>${product.title}</td>
					<td>${product.price}</td>
					<td>${product.description}</td>
					<td>${product.category}</td>
					<td>${product.rating.rate}</td>
					<td>${product.rating.count}</td>
				</tr>
			`;
			placeholder.innerHTML = out;
	}
	)}

// createbutton.addEventListener=("click",()=>{
// 	createproduct();
// });


 //getposts function ends here...
// getbutton.addEventListener=("click",()=>{
// 	displayproducts();
// });
