import { useEffect, useState } from "react";

import { DropDown, StockTable } from "components";
import useStockSelectors from "redux/selectors/useStockSelectors";

import useStock from "./useStock";
import { tableMetaData } from "./label";

const Stock = () => {
  const [tickerId, setTickerId] = useState("");
  const [priceSourceId, setPriceSourceId] = useState("");

  const {
    selectedTickerData,
    selectedStockTableData,
    selectedPriceSourceData,
  } = useStockSelectors();
  const { getPriceSources, getTickers, getStockValues, resetStockTable } =
    useStock();

  const handlePriceSource = async (value) => {
    setTickerId("");
    setPriceSourceId(value);
    if (!value) {
      resetStockTable();
      return;
    }
    await getTickers(value);
  };

  const handlePriceSourceTicker = async (value) => {
    setTickerId(value);
    if (!value) {
      resetStockTable();
      return;
    }
    await getStockValues(priceSourceId, value);
  };

  useEffect(() => {
    getPriceSources();
    // eslint-disable-next-line
  }, []);

  return (
    <div className="stock-container">
      <div className="stock-input-container">
        <DropDown
          label="Price Source:"
          value={priceSourceId}
          onChange={handlePriceSource}
          options={selectedPriceSourceData}
        />
        <DropDown
          label="Ticker:"
          value={tickerId}
          options={selectedTickerData}
          onChange={handlePriceSourceTicker}
        />
      </div>
      <StockTable
        tableMeta={tableMetaData}
        tableData={selectedStockTableData}
      />
    </div>
  );
};

export default Stock;
