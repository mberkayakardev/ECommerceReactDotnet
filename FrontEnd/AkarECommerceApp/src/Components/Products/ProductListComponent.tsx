function ProductListComponent (props: any){

    return (
        <>
        {
            props.ProductListesi.map((x : any)=>
                {
                    return (
                        <Product key={x.Id} product={x}/>
                    )
                }
            )
        }

        <button onClick={props.method1}> Ekle </button>

        </>
        )
    }

function Product(props :any){
    return (
        <>
            <div style={{ border: '1px solid gray', padding: '10px', margin: '5px', borderRadius: '8px' }}>
              <p>Id: {props.product.id}</p>
              <p>Adı: {props.product.name}</p>
              <p>Yaşı: {props.product.age}</p>
            </div>
            </>
          )
}

export default ProductListComponent