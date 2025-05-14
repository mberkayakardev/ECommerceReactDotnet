import Typography from '@mui/material/Typography';
import { useDispatch, useSelector } from 'react-redux';
import { RootState } from '../Store/AppStore.ts';
import { decrement, increment } from './Catologs/counterSlice.tsx';



export default function AboutPage()
{
    const count = useSelector((state: RootState) => state.counter.value);
    const Methods = useDispatch()

    return(
        <>
        <Typography variant="h6" > Akar E-Ticaret About Page  {count}</Typography>
        <button   onClick={() => Methods(increment())}> Arttır </button>
        <button  onClick={() => Methods(decrement())}> azalt  </button>
        </>
    )
}