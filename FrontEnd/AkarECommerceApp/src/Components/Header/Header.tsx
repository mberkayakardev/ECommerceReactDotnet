import { IProduct } from "../../Model/IProduct"

// Appbar komponentinde yer alan öğeler import edildi 
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import IconButton from '@mui/material/IconButton';
import MenuIcon from '@mui/icons-material/Menu';
import { NavLink } from "react-router";
import { Badge, colors, List, ListItem } from "@mui/material";
import { CenterFocusStrong, ShoppingCart } from "@mui/icons-material";
import { useDispatch, useSelector } from 'react-redux';
import { RootState } from '../Store/AppStore.ts';
import { decrement, increment } from './Catologs/counterSlice.tsx';



/// Dinamik bir şeklide linklerin dolduğu senaryoyu düşünelim. 
const NavLinks = [
    { text : "Ürünler" , to :"/" },
    { text : "Hakkında" , to :"/about" },
    { text : "İletisim" , to :"/contact" }
]

/// sx propertysi ile bizler komponentlerimize style verebilmekteyiz. 
const navStyles = {
    color: "inherit",
    textDecoration:"none",
    "&:hover":{
        color:"text.primary"
    },
    "&.active":{
        color:"warning.main"
    }
}

function Header(){

    const count = useSelector((state: RootState) => state.counter.value);
    const Methods = useDispatch()
   
    return (
        
        <Box sx={{ flexGrow: 1 }}>
            <AppBar position="static"> 
                <Toolbar sx={{display:"flex", justifyContent:"space-between"}}> 
                    <Box sx={{display:"flex", alignItems:"center"}}>
                        
                        {/* bir yazı eklemek istersen Typeografi olarak eklenecek variant ile h6 tipinde bir etiket oluşturulacağını belirliyoruz.  */}
                        <Typography variant="h6"  > Akar E-Ticaret  </Typography>
                        
                        {/* list komponenti kullanıyoruz elemanlar yan yana gelsin diye flex yaptık sx ile css yazabiliyoruz   List ul ye listitem ise li ye karşılık gelir html de */}
                        <List sx={{display:"flex"}}>  
                        {
                            NavLinks.map(L => 
                                // React Router içerisinden navlink imiz var 
                                // Normalde bir link eklersek tüm sayfa sıfırdan yenilenir
                                // Sayfa yenilenmeden komonentler arası geçiş için gerekiyor

                                <ListItem component={NavLink} to={L.to} sx={navStyles} > { L.text } </ListItem>
                                    
                            )
                        }
                        </List>

                    </Box>

                    <Box sx={{display:"flex", alignItems:"center"}}>
                    <Button component={NavLink}  sx={navStyles} to="/login"> Login </Button>
                        <IconButton size="large" edge="start" color="inherit">
                            <Badge badgeContent={count} color="secondary">
                                <ShoppingCart/>
                            </Badge>
                        </IconButton>
                    </Box>

                    
                </Toolbar>
            </AppBar>
        </Box>
    )
}


export default Header