function ColorBlock() {
    const randomColor = '#' + Math.floor(Math.random() * 16777215).toString(16);
    return (
        <div className="col-1" style={{ backgroundColor: randomColor, minHeight: 50, minWidth: 50 }}>
            {randomColor}
        </div>
    )
}

export default ColorBlock;