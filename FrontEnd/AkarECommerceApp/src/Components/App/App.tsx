import { useEffect, useState } from 'react'
import '../App/App.css'
import { IProduct } from '../../Model/IProduct';
import Header from '../Header/Header';
import ProductListComponent from '../Products/ProductListComponent';
import { Container, CssBaseline } from '@mui/material';

const MyArray = [
  { id: 1, name: "Berkay", age: 28 },
  { id: 2, name: "Ayşe", age: 24 },
  { id: 3, name: "Mehmet", age: 32 },
  { id: 4, name: "Hasan", age: 32 },

];
  // const [count, setCount] = useState("Berkay")
function App() {
  
  const [ProductList, setlist ] = useState<IProduct[]>([]);

  
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
        <CssBaseline/>
        <Header ProductListesi = {ProductList}/>

        <Container>
          <ProductListComponent ProductListesi = {ProductList} method1 = {AddProduct}/>
        </Container>
      </>
      )
}

function Component1(){
  return(
  <>
    <h1> Component1 (1. Komponent )</h1>
      <Component2/>
    </>

  )
}
function Component2(){
  return(
    <>
    <h2> Component 2 (2. Komponent)  </h2>
    <Component3/>
    </>
  )
}
// function Component3(){
//   return(
//     <>
//     <h3> Component 3 (3.Komponentim ) </h3>
//     {
//       MyArray.map(x => {
//           // return <Component4 key={x.id} name={x.name} age={x.age} />
//           return <Component4 key={x.id} product={x} />
//         })
//       }
//         <Component5/>
//     </>
//   )
// }

// function Component5 (){
//   function Ekleme(){
//     MyArray.push({
//       id : 25,
//       name:"berkay yeni",
//       age:34
//     })
//     console.log(MyArray)
//   }
  
//   return(
//     <button onClick={Ekleme}> Yeni bir element ekle </button>
//   )
// }
/// Çalışır
// function Component4({ name, age }) {
//   return (
//     <div style={{ border: '1px solid gray', padding: '10px', margin: '5px', borderRadius: '8px' }}>
//       <p>Ad: {name}</p>
//       <p>Yaş: {age}</p>
//     </div>
//   )
// }
/// Props any diyere typescript kullandığımız için tip zorunluluğu 
// koşmadan herhangi bir tip manasına gelecek şekilde belirtiyoruz. 
/// Henüz bir tipi yok. props olarak gönderilen veri herhangi bir tipte olur. 
/// Javascriptte buna gerek yok ama typescriptte yazalım. güvenlik açısından 

// function Component4(props:any) {
//   return (
//     <div style={{ border: '1px solid gray', padding: '10px', margin: '5px', borderRadius: '8px' }}>
//       <p>Id: {props.product.id}</p>
//       <p>Adı: {props.product.name}</p>
//       <p>Yaşı: {props.product.age}</p>
//     </div>
//   )
// }


// function Component3(){
//   /// Artık bizler state üzerinde bir array tutalım ve bunun üzerinde işlem yapalım.

//   /// İlk etapta state tanımlayalım.
//   /// const [etkilenecek veri listesi, bu listeyi güncelleyecek olan method ismi ] 
//   const [ProductList, setlist ] = useState( [{ id: 1, name: "Berkay", age: 28 },
//                                              { id: 2, name: "Ayşe", age: 24 },
//                                              { id: 3, name: "Mehmet", age: 32 },
//                                              { id: 4, name: "Hasan", age: 32 }, ]); /// import use state i otomatik olarak import etmezse sen elle import et. Başlangıçta olmasını istediğiniz berileri UseState() içerisine ekleyebilirsin  
    
//     /// Verileri güncellemek istediğimizde setlist methodu ile güncelleyebilirsiniz. set list ile tüm veriyi güncelleyeceğiniz için state ten okuyup üzeirne ekleme yapın
//     function AddProduct(){
//       /// İlk etapte state içerisindeki veriyi alıp içerisine veri ekliyosun ve bu şekilde setliyosun tek tek setlemiyosun
//       setlist([...ProductList, {id : 120, name:"Deneme" , age:20}])
//     } 


 
//     return(
//       <>
//       <h3> Component 3 (3.Komponentim ) </h3>
//       {
//         ProductList.map(x => {
//             // return <Component4 key={x.id} name={x.name} age={x.age} />
//             return <Component4 key={x.id} product={x} />
//           })
//       }
//        {
//       console.log('deneme return ')
// }
//       <h3> Component 3 (3.Komponentim ) </h3>
      
//       <button onClick={AddProduct}> Yeni bir element ekle </button>
//       </>
//     )
//   }


// function Component3(){
//   /// Artık bizler state üzerinde bir array tutalım ve bunun üzerinde işlem yapalım.

//   /// İlk etapta state tanımlayalım.
//   /// const [etkilenecek veri listesi, bu listeyi güncelleyecek olan method ismi ] 
//   const [ProductList, setlist ] = useState([]); /// import use state i otomatik olarak import etmezse sen elle import et. Başlangıçta olmasını istediğiniz berileri UseState() içerisine ekleyebilirsin  

                                             
// useEffect( ()=> {
  
//   fetch("https://localhost:7132/api/Products")
//     .then( x=> x.json())
//     .then( y=> { console.log(y); setlist(y.data)}
  
  
//   )},[])

   


 
//     return(
//       <>
//       <h3> Component 3 (3.Komponentim ) </h3>
//       {
//         ProductList.map(x => {
//             // return <Component4 key={x.id} name={x.name} age={x.age} />
//             return <Component4 key={x.id} product={x} />
//           })
//       }
//        {
//       console.log('deneme return ')
// }
      
//       </>
//     )
//   }


// function Component3(){
 
//   const [ProductList, setlist ] = useState<IProduct[]>([]);  /// Tip atamamızı interface ile yaptık. 
                                             
// useEffect( ()=> {
  
//   fetch("https://localhost:7132/api/Products")
//     .then( x=> x.json())
//     .then( y=> { console.log(y); setlist(y.data)}
  
//   )},[])
//     return(
//       <>
//       <h3> Component 3 (3.Komponentim ) </h3>
//       {
//         ProductList.map(x => {
//             // return <Component4 key={x.id} name={x.name} age={x.age} />
//             return <Component4 key={x.id} {...x} />
//           })
//       }
//        {
//       console.log('deneme return ')
// }
//       </>
//     )
//   }

//   function Component4(props: IProduct) {
//     return (
//       <div style={{ border: '1px solid gray', padding: '10px', margin: '5px', borderRadius: '8px' }}>
//         <p>Id: {props.id}</p>
//         <p>Adı: {props.productName}</p>
//         <p>Açıklaması: {props.productDescription}</p>
//         <p>Fiyat : {props.productPrice}</p>
//         <p>Stok : {props.stock}</p>


//       </div>
//     )
//   }

  






export default App
