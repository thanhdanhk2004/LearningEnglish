import Header from "./component/layout/header";
import Footer from "./component/layout/footer";

const MainLayout = ({children}) =>{
    return(
        <>
            <Header/>
            <main>{children}</main>
            <Footer/>
        </>
    )
}
export default MainLayout