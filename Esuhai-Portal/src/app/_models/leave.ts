import { Time } from '@angular/common';

export interface Leave {
    nhanVienNghiPhepId: number,
    nhanVienNghiPhepFullName: string,
    nhanVienNghiPhepMaNV: string,
    nhanVienNghiPhepUsername: string,
    nhanVienNghiPhepDepartmentId: number,
    nhanVienNghiPhepDepartmentDeptName: string,
    nhanVienNghiPhepSectionId: number,
    nhanVienNghiPhepSectionName: string,
    nhanVienNghiPhepTbxetDuyet: number,
    nhanVienNghiPhepTpxetDuyet: number,
    startTime: Time,
    endTime: Date,
    days: number,
    leaveStatus: string,
    requestStatus: string,
    truongBanApprovalStatus: string,
    truongPhongApprovalStatus: string,
    hrApprovalStatus: string,
    noiDungThayThe: string,
    lyDoNghi: string,
    nhanVienNghiPhepChucDanh: string
}
