import Header from '../Components/Header/Header';
import React, { useEffect, useState } from 'react';
import ProductListComponent from '../Components/Products/ProductListComponent';
import { Container} from '@mui/material';
import Typography from '@mui/material/Typography';


export default function CatologPage(){
 
    const [ProductList, setlist ] = useState([]);

    useEffect( ()=> {
      fetch("https://localhost:7132/api/Products")
      .then( x=> x.json())
      .then( y=> { console.log(y); setlist(y.data)}
    
    )},[])
  
    function AddProduct(){
      setlist(
        [ ...ProductList,
          { 
            id: 155,
            isActive: true,
            createdDate: Date.now().toString(),
            createdUserId: null,
            createdUserName: null,
            modifiedDate: Date.now().toString(),
            modifiedUserId:  null,
            modifiedUserName: null,
            productDescription: "Description 1 ",
            productDescriptionForTextEdit: "description 2 ",
            productName: "Product Name 1 ",
            productPrice: 1,
            stock: 1
          }])
    }
  
    return (
          <>
          <Container>
            <ProductListComponent ProductListesi = {ProductList} method1 = {AddProduct}/>
          </Container> 
        </>
        )

}