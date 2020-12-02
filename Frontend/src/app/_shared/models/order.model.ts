export interface Order {
    senderName: string;
    senderEmail: string;
    recipientName: string;
    recipientEmail: string;
    voucher: string;
    dedication?: string;
    orderDate?: Date;
}
