import { IProduct } from "../../Model/IProduct"

// Appbar komponentinde yer alan öğeler import edildi 
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';


function Header(props : any){
    return (
        
        <Box sx={{ flexGrow: 1 }}>
            <AppBar position="static"> 
                <Toolbar> 
                    {/* <IconButton size="large" edge="start" color="inherit" aria-label="menu" sx={{ mr: 2 }} >
                        <MenuIcon />
                    </IconButton>
                     */}
                    {/* bir yazı eklemek istersen Typeografi olarak eklenecek variant ile h6 tipinde bir etiket oluşturulacağını belirliyoruz.  */}
                    <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}> Akar E-Ticaret  </Typography>
                    
                    <Button color="inherit">Login</Button>
                    
                </Toolbar>
            </AppBar>
        </Box>
    )
}


export default Header