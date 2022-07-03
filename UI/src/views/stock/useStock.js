import { useState } from "react";

import useStockActions from "redux/actions/useStockActions";
import { StockService } from "services/stockService";
import { ErrorMessages } from "utils/constants";
import { toast } from "react-toastify";

const useStock = () => {
  const [loading, setLoading] = useState(false);

  const {
    setTickerDataDispatch,
    setStockTableDataDispatch,
    setPriceSourceDataDispatch,
  } = useStockActions();

  const getPriceSources = async () => {
    setLoading(true);
    try {
      const res = await StockService.getPriceSources();
      if (res) {
        setPriceSourceDataDispatch(res);
      }
    } catch {
      setPriceSourceDataDispatch(null);
      toast.error(ErrorMessages.somethingWentWrong);
    } finally {
      setLoading(false);
    }
  };

  const getTickers = async (priceSourceId) => {
    setLoading(true);
    resetStockTable();
    try {
      const res = await StockService.getTickers(priceSourceId);
      if (res) {
        setTickerDataDispatch(res);
      }
    } catch {
      setTickerDataDispatch(null);
      toast.error(ErrorMessages.somethingWentWrong);
    } finally {
      setLoading(false);
    }
  };

  const getStockValues = async (priceSourceId, tickerId) => {
    setLoading(true);
    try {
      const res = await StockService.getStockValues(priceSourceId, tickerId);
      if (res) {
        setStockTableDataDispatch(res);
      }
    } catch {
      setStockTableDataDispatch(null);
      toast.error(ErrorMessages.somethingWentWrong);
    } finally {
      setLoading(false);
    }
  };

  const resetStockTable = () => {
    setTickerDataDispatch(null);
    setStockTableDataDispatch(null);
  };

  return {
    loading,
    getTickers,
    getStockValues,
    getPriceSources,
    resetStockTable,
  };
};

export default useStock;
