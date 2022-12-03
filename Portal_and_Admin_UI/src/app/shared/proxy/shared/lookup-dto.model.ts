
export interface LookupDto<Type> {
  (info: Type): Type;
  id: Type;
  name: string;
}

export interface LookupExtention {
  name: string,
  code: string
}
