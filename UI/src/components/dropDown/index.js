const DropDown = ({ label, value, options, onChange }) => {
  return (
    <div className="ticker-select">
      <label>{label}</label>
      <select
        value={value}
        aria-label="ticker-input"
        onChange={(e) => onChange(e.target.value)}
      >
        <option value={""}>Select option ...</option>
        {options && options.length
          ? options.map((item) => (
              <option key={item.id} value={item.id}>
                {item.name}
              </option>
            ))
          : null}
      </select>
    </div>
  );
};

export default DropDown;
