const cars = ["Saab", "Volvo", "BMW"];

function BaseProductComponent(){
    return(
        <>
        {
            cars.map((i) => {
                return (<Product/>)
            })
        }
        </>
    )
}


function Product (){
    return (
        <>
        <p>
            İtem1
        </p>
        </>
    )
}

export default  BaseProductComponent;