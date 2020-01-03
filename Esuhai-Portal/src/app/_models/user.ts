import { Department } from './department';

export interface User {
  employeeId: number;
  fullName: string;
  birthday?: Date;
  imageUrl?: string;
  maNV: string;
  username: string;
  departmentId?: number;
  sectionId?: number;
  departmentName: string;
  sectionName: string;
  listDepartments?: Department[];
  tpXetDuyet?: number,
  tbXetDuyet?: number,
  chucDanh: string,
  id: number
}