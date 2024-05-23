import { useState } from "react";
import { useNavigate } from "react-router-dom";
const keyname = "key";
const value = "hello world";

export default function Screen1() {
    const navigate = useNavigate();
    const handleSaveClick = () => {
        sessionStorage.setItem(keyname, value + "- session");
        localStorage.setItem(keyname, value + "- local");
    }
    const handleRemoveClick = () => {
        sessionStorage.removeItem(keyname);
        localStorage.removeItem(keyname);
    }
    return (
        <>
            <h1>Screen1</h1>
            <hr />
            <button onClick={handleSaveClick}>Save value to storage</button>
            <button onClick={handleRemoveClick}>Remove value storage</button>
            <hr />
            <button onClick={() => navigate("/screen2")}>Nav to Screen 2</button>
        </>
    )
}
