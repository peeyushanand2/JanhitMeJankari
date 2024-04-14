import { Outlet, Link } from "react-router-dom";


function NavUI() {
    return (

        <>
            <nav className="navbar navbar-expand-lg bg-body-tertiary">
                <div className="container-fluid">
                    <a className="navbar-brand" href="/">Onlineshopping.com</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNavDropdown">
                        <ul className="navbar-nav">
                            <li className="nav-item">
                                <Link className="nav-link active" to="/">Home</Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link active" to="/products">Products</Link>
                            </li>
                            <li className="nav-item dropdown">
                                <a className="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                    More
                                </a>
                                <ul className="dropdown-menu">
                                    <li>  <Link className="dropdown-item" to="/contact">Contact Us</Link></li>
                                    <li>  <Link className="dropdown-item" to="/about">About Us</Link></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <Outlet />
        </>


    );
}

export default NavUI;