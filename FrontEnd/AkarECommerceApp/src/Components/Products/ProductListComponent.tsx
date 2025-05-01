import { Grid } from '@mui/material';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';



function ProductListComponent (props: any){

    return (
        <Grid container spacing={2}>
          {

            props.ProductListesi.map((product : any) => (
                // <Grid key={product.id}>

              <Product key={product.id} product={product} />

            //   </Grid>

          ))}
        </Grid>
    )


}



function Product(props :any){
    return (
        <>
           <Card sx={{ maxWidth: 345, mt: 2 }}>
                <CardMedia component="img" alt="green iguana" height="140" image="https://picsum.photos/200/300" />
                    <CardContent>
                        <Typography gutterBottom variant="h5" component="div"> {props.product.productName} </Typography>
                        <Typography variant="body2" color="text.secondary">
                        {props.product.productPrice} 
                        </Typography>
                    </CardContent>
                <CardActions>
                    <Button size="small">Share</Button>
                    <Button size="small">Learn More</Button>
                </CardActions>
            </Card>
            </>

          )
}

export default ProductListComponent