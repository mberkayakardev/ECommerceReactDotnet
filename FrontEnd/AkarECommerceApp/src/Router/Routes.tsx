import { createBrowserRouter, Router } from "react-router"; // 
import App from '../Components/Landings/App/App';
import CatalogPage from '../Pages/Catologs/CatologPage';
import AboutPage from '../Pages/AboutPage';
import ContactPage from '../Pages/ContactPage';
import ProductDetailPage from '../Pages/ProductDetailPage';
import LoginLanding from "../Components/Landings/Login/LoginLanding";
import LoginPage from "../Pages/LoginPage";


// bir tane sabit döneceğiz 
export const router = createBrowserRouter(
    [
        // her bir root bu şekilde objeler şeklinde tanımlanır 
        {
            // ilgili path master path path ile belirlenecek bu path in child leri ise aşağıda tanımlanacakk
            // Elementi de buradaki Area gibi düşünebiliriz root component App component app conponent altındaki sayfalar çalışacak path e göre 
            // Uygulamanın ana dizininne geldiğinizde element olarak sizi AppComponent karşılayacak. 
            path: "/" ,
            element:<App/>,
            children: [
                // / sonuna gelecek olan linkler. 
                {
                    path:"",
                    element: <CatalogPage/>
                },
                {
                    path:"product/:id", /// verdiğin id değerine göre ilgili ürün ü getirecek 
                    element: <ProductDetailPage/>
                },
                {
                    path:"about",
                    element: <AboutPage/>
                },
                {
                    path:"contact",
                    element: <ContactPage/>
                }
            ]
        },
        {
            path: "/login" ,
            element:<LoginLanding/>,
            children: [
                {
                    path:"",
                    element: <LoginPage/>
                } 
            ]
        }
    ]

)