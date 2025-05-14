import { createSlice, PayloadAction } from "@reduxjs/toolkit"
import { act } from "react";

// state imizin ilk başta bir şeması olsun 
export interface CounterState {
    value : number
}

// bu etapta başlangıç state ini tanımlıyoruz tipini vererek. 
const initialState : CounterState = {
    value : 0  
}

// Bu state i kullanacağımız ve state e müdahale edecek, değerini değiştirecek olan slice methodlar
export const counterSlice = createSlice({
    
    // İsim verdik
    name:"counter",

    // başlangıç değeri 
    initialState,

    // Methodlar value ları güncellemeye yarayacak  
    reducers: {

        increment : (state) => {
            state.value += 1;
        },
        decrement : (state ) => {
            state.value -= 1;
        },
        // ACTİON DIŞARIDAN GÖNDERİLECEK PARAMETREYİ TEMSİL EDER
        incrementByValue : (state , action : PayloadAction<number>) => {

            // Action üzerinden gelen payload eklenecek. 
            state.value += action.payload
        }
    }
     

})

/// Bu aşamada ise methodlarımızı dışarı açıyoruz. 
export const {increment, decrement, incrementByValue} = counterSlice.actions