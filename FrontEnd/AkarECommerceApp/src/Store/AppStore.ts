import { configureStore } from "@reduxjs/toolkit";
import { counterSlice } from "../Pages/Catologs/counterSlice";

// bir store tanımladık
// Store içerisinde birden çok state olabilir. 
// örnek olarak counter state tanımlıyoruz. 
// Store dediğimiz yer bütün state lerin yönetildiği yerdir. 


/// Bir tane store tanımladık adı AuthStore olan. 
export const AppStore = configureStore({


    /// bu reducer burada slice ler burada tanımlanacak 
    // yani state ve state e müdahale eden fonkisyonların tanımlandığı klasörler buraya refgister edilecek. 
    reducer: {
        /// ilk parameter isim : den sonrası ise bağlanacak slice 
        counter: counterSlice.reducer

    }
})   

/// ilgili store yani appstore için tüm state bilgilerini döner. süm store un state tipini temsil eden  bir typescript parçası 
export type RootState = ReturnType<typeof AppStore.getState>

//// Aksiyon göndermemize yaramaktadır. 
export type AppDispatch = typeof AppStore.dispatch