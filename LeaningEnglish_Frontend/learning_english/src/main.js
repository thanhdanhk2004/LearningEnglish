import { BrowserRouter, Route, Routes } from "react-router-dom"
import MainLayout from "./main_layout"
import Home from "./component/home"

const Main = () =>{
    return(
        <>
            <BrowserRouter>
                <Routes>
                    <Route path="/" element={<MainLayout ><Home /></MainLayout>} />
                </Routes>
            </BrowserRouter>
        </>
    )
}

export default Main