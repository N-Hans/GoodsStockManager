import { GoodsManagementType } from "./enumerations/goodsManagementType.enum";

export class Good {

  code: string;
  description: string;
  isActive: boolean;
  foreignDescription: string;
  isSalesItem: boolean;
  isStockItem: boolean;
  isPurchasedItem: boolean;
  barcode: string;
  manageItemBy: GoodsManagementType;
  minimumInventory: number;
  maximumInventory: number;
  remarks: string;
  image: string;
}
