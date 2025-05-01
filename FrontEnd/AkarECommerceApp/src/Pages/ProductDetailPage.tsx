import Typography from '@mui/material/Typography';
import { useEffect, useState } from 'react';
import { useParams } from 'react-router';
import { Box, CircularProgress, List, ListItem } from '@mui/material';
import { Grid, Button, Paper  } from '@mui/material';
import {
    Table,
    TableBody,
    TableRow,
    TableCell,
  } from '@mui/material';
import { IProduct } from '../Model/IProduct';

export default function ProductDetailPage(){

    // Gelen id bilgisini alacağız ve veritabanına bir sorgulama işlemi yapcacağız.
    // UseParams hook u ile bizler alma işlemini sağlayacağız.

    // product/:id şeklinde isimlendirdiğimiz için değişkene id dedik routing ayarında ne verdiysek o router içerisinde 
    const { id } = useParams() 
    
    /// Product i tutacağımız state 
    const[product , setProduct] = useState<IProduct>();
    const [loading, setLoading] = useState(true);


    /// Sonsuz döngüye girmemek için kullanacak olduğumuz yapı. 
        useEffect( ()=> {
          fetch(`https://localhost:7132/api/products/${id}`)
          .then( x=> x.json())
          .then( y=> { 
            console.log(y);
            setProduct(y.data)
            setLoading(false)
        })},[])
        
        if (loading) {
            return (
              <Box
                display="flex"
                flexDirection="column"
                alignItems="center"
                justifyContent="center"
                height="100vh"
              >
                <CircularProgress />
                <Typography mt={2}>Yükleniyor...</Typography>
              </Box>
            );
          }

          
    return (
        <>
            <Box p={4}>
                <Grid container spacing={4}>
                    <Grid item xs={12} md={6}>
                        <img src={"https://picsum.photos/500/500"} alt={product?.productName} style={{ width: '100%', borderRadius: 10 }}/>
                    </Grid>
                    
                    <Grid item xs={12} md={6}>
                        <Typography variant="h4" gutterBottom> {product?.productName} </Typography>
                        <Typography variant="h5" color="purple" gutterBottom> {product?.productPrice.toFixed(2)} ₺ </Typography>
                        
                        <Table>
                            <TableBody>
                                <TableRow>
                                    <TableCell><strong>{"Name"}</strong></TableCell>
                                    <TableCell>{product?.productName}</TableCell>
                                    
                                </TableRow>
                                <TableRow>
                                    <TableCell><strong>Description</strong></TableCell>
                                    <TableCell>{product?.productDescription}</TableCell>
                                    </TableRow>
                                
                                <TableRow>
                                    <TableCell><strong>Stock</strong></TableCell>
                                    <TableCell>{product?.stock}</TableCell>
                                </TableRow>
                            </TableBody>
                        </Table>
                    </Grid>
                </Grid>
            </Box>
        </>
    )
}