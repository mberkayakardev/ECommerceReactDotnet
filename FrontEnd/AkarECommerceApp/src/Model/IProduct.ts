export interface IProduct {
    id: number;
    isActive: boolean;
    createdDate: string;
    createdUserId: number | null;
    createdUserName: string | null;
    modifiedDate: string;
    modifiedUserId: number | null;
    modifiedUserName: string | null;
    productDescription: string;
    productDescriptionForTextEdit: string;
    productName: string;
    productPrice: number;
    stock: number;
  }
  