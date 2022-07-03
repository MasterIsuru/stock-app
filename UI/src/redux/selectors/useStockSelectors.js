import { useSelector } from "react-redux";

const useStockSelectors = () => {
  const selectedTickerData = useSelector(
    (state) => state.stock.tickerData
  );
  const selectedStockTableData = useSelector(
    (state) => state.stock.stockTableData
  );
  const selectedPriceSourceData = useSelector(
    (state) => state.stock.priceSourceData
  );

  return {
    selectedTickerData,
    selectedStockTableData,
    selectedPriceSourceData,
  };
};

export default useStockSelectors;
