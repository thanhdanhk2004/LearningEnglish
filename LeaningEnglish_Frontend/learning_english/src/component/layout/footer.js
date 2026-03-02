import "bootstrap/dist/css/bootstrap.min.css"

const Footer = () => {
    return (
        <>
            <footer className="bg-primary text-center text-white">
                <div className="container p-4 pb-0">
                    <section className="mb-4">
                        <a
                            data-mdb-ripple-init=""
                            className="btn btn-outline-primary btn-floating m-1 border border-white"
                            href="#!"
                            role="button"
                        >
                            <i className="fab fa-facebook-f text-white" />
                        </a>
                        <a
                            data-mdb-ripple-init=""
                            className="btn btn-outline-primary btn-floating m-1 border border-white"
                            href="#!"
                            role="button"
                        >
                            <i className="fab fa-twitter text-white" />
                        </a>
                        <a
                            data-mdb-ripple-init=""
                            className="btn btn-outline-primary btn-floating m-1 border border-white"
                            href="#!"
                            role="button"
                        >
                            <i className="fab fa-google text-white" />
                        </a>
                        <a
                            data-mdb-ripple-init=""
                            className="btn btn-outline-primary btn-floating m-1 border border-white"
                            href="#!"
                            role="button"
                        >
                            <i className="fab fa-instagram text-white" />
                        </a>
                        <a
                            data-mdb-ripple-init=""
                            className="btn btn-outline-primary btn-floating m-1 border border-white"
                            href="#!"
                            role="button"
                        >
                            <i className="fab fa-linkedin-in text-white" />
                        </a>
                        <a
                            data-mdb-ripple-init=""
                            className="btn btn-outline-primary btn-floating m-1 border border-white"
                            href="#!"
                            role="button"
                        >
                            <i className="fab fa-github text-white" />
                        </a>
                    </section>

                </div>  
                <div
                    className="text-center p-3"
                    style={{ backgroundColor: "rgba(0, 0, 0, 0.2)" }}
                >
                    © 2020 Copyright:
                    <a className="text-white" href="https://mdbootstrap.com/">
                        MDBootstrap.com
                    </a>
                </div>

            </footer>
        </>

    )
}

export default Footer