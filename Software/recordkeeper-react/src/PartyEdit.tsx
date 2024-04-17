export function PartyEdit() {

    return (
        <div className="bg-light mt-4 p-4">
            <div className="row">
                <div className="col-12">
                    <h2 id="hmsg"></h2>
                </div>
            </div>
            <div className="row">
                <div className="col-12">
                    <form id="frm" action="" method="post" className="needs-validation">
                        <div className="mb-3">
                            <label htmlFor="partyId" className="form-label">Party ID:</label>
                            <input type="number" id="txtpartyid" name="partyId" value="0" className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="partyName" className="form-label">Party Name:</label>
                            <input type="text" id="partyName" name="partyName" value="coffee party" className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="yearStart" className="form-label">Year Start:</label>
                            <input type="number" id="yearStart" name="yearStart" value="2000" className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="colorId" className="form-label">Color ID:</label>
                            <select name="colorId" id="lstcolor" className="form-select"></select>

                        </div>

                        <div className="mb-3">
                            <label htmlFor="partyDesc" className="form-label">Party Description:</label>
                            <input type="text" id="partyDesc" name="partyDesc" value="drink coffee" className="form-control" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="partyColor" className="form-label">Party Color:</label>
                            <input type="text" id="partyColor" name="partyColor" value="black" className="form-control" required />
                        </div>

                        <button type="submit" className="btn btn-primary">Submit</button>
                        <button id="btndelete" className="btn btn-danger">Delete</button>
                    </form>
                </div>
            </div>
        </div>
    )
}