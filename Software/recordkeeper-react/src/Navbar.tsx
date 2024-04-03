export default function Navbar() {
    return (
        <>
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
                <div className="container-fluid">
                    <a className="navbar-brand" href="#">
                        <img src="/images/brand.jpg" alt="" width="100" className="d-inline-block pe-3" />
                        Record Keeper
                    </a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav">
                            <li className="nav-item">
                                <a className="nav-link active" aria-current="page" href="#">U.S. Gov</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">Olympics</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </>
    )
}