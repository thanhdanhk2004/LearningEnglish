import header from "./component/layout/header";
import footer from "./component/layout/footer";

const mainlayout = ({children}) =>{
    return(
        <>
            <header />
            <main>{children}</main>
            <footer />
        </>
    )
}
export default mainlayout