fetch("https://fakestoreapi.com/products/")
    .then(res=>{

    return response.json();
    })
    .then(products=>{
        let placeholder=document.querySelector("#productlist");  
        let out= "";
        for(let product of productslist){
        out +=`
        <tr>
        <td> <img src='${product.image}'></td>
        <td> ${product.id}</td>
        <td> ${product.title}</td>
        <td> ${product.description}</td>
        <td> ${product.category}</td>
        <td> ${product.price}</td>
        <td> ${product.rating}</td>
        


        </tr>
            
    `;
        }
        placeholder.innerHTML=out;
    })


        
        
        
        const apiDataElement = document.getElementById('apiData');
        const newproduct=document.getElementById("newproduct")
        const deleteproduct=document.getElementById("deleteproduct")

        const nextButton = document.getElementById('nextButton');

        const previousButton = document.getElementById('previousButton');

        const update = document.getElementById('update');

        let i = 1;



 

        function displayNextProduct() {

            fetch(`https://fakestoreapi.com/products/${i}`)

            .then(res => res.json())

            .then(d => {

                const productId = `product_${i}`;
                

                const htmlContent = `

                    <div id="${productId}">
                        <h2>${i}</h2>
                        <h2>${d.title}</h2>

                        <p>Price: $${d.price}</p>

                        <p>Description: ${d.description}</p>

                        <p>Category: ${d.category}</p>

                        <img src="${d.image}" alt="${d.title}" width="200">

                        <p>Rating :${d.rating}</p>

                    </div>

                `;

                apiDataElement.innerHTML = htmlContent;

                i++;

            });

        }

 

        function displayPreviousProduct() {

            var a=i;

            if (a <= i) {

                i--;

                displayNextProduct();

            }

        }

 

        function displayUpdateProduct() {

            const a = parseInt(prompt("Enter the product Id number: "));

                i = a;

                displayNextProduct();

            }
            function displaydeleteproduct()
            {
                fetch("https://fakestoreapi.com/products/", {
                
             })
             .then(response => {
                if (response.ok) {
                  alert('Product deleted successfully.');
                } else {
                  alert('Failed to delete product.');
                }
              })
              .catch(error => {
                alert('Error:', error);
              });
            
               

            }
 
        // 
        deleteproduct.addEventListener('click',displaydeleteproduct);
        nextButton.addEventListener('click', displayNextProduct);

        displayNextProduct();

        previousButton.addEventListener('click', displayPreviousProduct);

        update.addEventListener('click', displayUpdateProduct);

    

 